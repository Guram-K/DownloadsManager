using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Implementation.Services
{
    public class ReadWriter
    {
        public string Location { get; set; } = @"D:\Downloads\.DownloadsManagerBin\extensions.txt";

        private ReadWriter() { }
        private static ReadWriter Instance;

        public static ReadWriter GetInstance()
        {
            Instance = Instance == null ? new ReadWriter() : Instance;

            return Instance;
        }

        public async Task Write(IEnumerable<string> list)
        {
            using (StreamWriter stream = new StreamWriter(Location))
            {
                stream.Write(string.Join(",", list));
            }
        }

        public async Task<IEnumerable<string>> Read()
        {
            try
            {
                using (StreamReader stream = new StreamReader(Location))
                {
                    var result = await stream.ReadToEndAsync();
                    var output = result.Split(',');

                    return output;
                }
            }
            catch (Exception ex)
            {
                var exc = ex.Message.ToString();
                return default;
            }
        }

        public async Task<bool> Delete(string deleteMe)
        {
            try
            {
                var output = (await Read()).ToList();
                output.Remove(deleteMe);
                await Write(output);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
