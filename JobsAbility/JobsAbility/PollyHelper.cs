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
        public static bool TextToMp3Async(string text,string filename)
        {
            try
            {
                textToVoice = text;
                outputFilename = filename;
                Task.Run(RecordFile).Wait();
                return true;
            }
            catch (Exception)
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
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MediaFiles", "AudioFiles",outputFilename+ ".mp3");
            using (var fileStream = File.Create(path))
            {
                sres.AudioStream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
        }
    }
}
