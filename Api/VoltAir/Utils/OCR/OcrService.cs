using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace VoltAir.Utils.OCR
{
    public class OcrService
    {
        private readonly string _subscriptionKey = "f1159f614a684ab79521816cbf2306db";

        private readonly string _endpoint = "https://vcvoltair.cognitiveservices.azure.com/";

        public async Task<string> RecognizeTextAsync(Stream imageStream)
        {
            try
            {
                var client = new ComputerVisionClient(new ApiKeyServiceClientCredentials
                    (_subscriptionKey))
                {
                    Endpoint = _endpoint
                };

                var ocrResult = await client.RecognizePrintedTextInStreamAsync(true, imageStream);

                return ProcessRecognitionResult(ocrResult);
            }
            catch (Exception ex)
            {

                return "Erro ao reconhecer o texto" + ex.Message;
            }
        }

        private static string ProcessRecognitionResult(OcrResult result)
        {
            string recognizedText = "";

            foreach (var region in result.Regions)
            {
                //para cada regiao percorre as linhas
                foreach (var line in region.Lines)
                {
                    //para cada linha percorre as palavras
                    foreach (var word in line.Words)
                    {
                        //adiciona cada palavra ao texto, separando com espaco
                        recognizedText += word.Text + " ";
                    }

                    //quebra de linha ao final de cada linha
                    recognizedText += "\n";
                }

            }
                //retorna o texto
                return recognizedText;
        }
    }
}
