using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace JobsAbility
{
    public class PollyHelper
    {
        private static string outputFilename;
        private static string textToVoice;
        public static string dirpath;
        static PollyHelper()
        {
            dirpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MediaFiles", "AudioFiles");
        }
        public static string GetSentenceMp3(string text)
        {
            using (var db = new JobsAbility.Models.jobsDBContext())
            {
                var voiceObj = db.SentenceVoice.Where(a => a.Sentence == text.Trim()).FirstOrDefault();
                if (voiceObj == null)
                {
                    var _newVoiceObj = new Models.SentenceVoice
                    {
                        Sentence = text.Trim()
                    };
                    db.SentenceVoice.Add(_newVoiceObj);
                    db.SaveChanges();
                    PollyHelper.TextToMp3Async(text.Trim(), _newVoiceObj.Id + "");
                    _newVoiceObj.AudioLink = System.IO.Path.Combine(Config.GetValue("hostURL"), PollyHelper.GetAudioDir(), _newVoiceObj.Id + ".mp3");
                    db.SaveChanges();
                    return System.IO.Path.Combine(Config.GetValue("hostURL"), PollyHelper.GetAudioDir(), _newVoiceObj.Id + ".mp3");
                }
                else
                {
                    return System.IO.Path.Combine(Config.GetValue("hostURL"), PollyHelper.GetAudioDir(), voiceObj.Id + ".mp3");
                }
            }
        }
        public static bool IsSentenceExistPhyiscally(string id)
        {
            var path = Path.Combine(dirpath,id+ ".mp3");
            return File.Exists(path);
        }
        public static string GetAudioDir()
        {
            return Path.Combine("MediaFiles", "AudioFiles");
        }
        public static bool TextToMp3Async(string text,string filename)
        {
            try
            {
                textToVoice = text;
                outputFilename = filename;
                Task.Run(RecordFile).Wait();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        private static async Task RecordFile()
        {
            AmazonPollyClient pc = new AmazonPollyClient(AmazonCredHelper.AwsCredintals, Amazon.RegionEndpoint.USEast2);

            SynthesizeSpeechRequest sreq = new SynthesizeSpeechRequest();
            sreq.Text = textToVoice;
            sreq.OutputFormat = OutputFormat.Mp3;
            sreq.VoiceId = VoiceId.Joey;
            SynthesizeSpeechResponse sres = await pc.SynthesizeSpeechAsync(sreq);
            var path = Path.Combine(dirpath, outputFilename+ ".mp3");
            using (var fileStream = File.Create(path))
            {
                sres.AudioStream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
        }
    }
}
