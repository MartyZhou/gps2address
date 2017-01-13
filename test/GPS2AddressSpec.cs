using System.IO;
using Newtonsoft.Json;
using Xunit;

namespace Cluj.GPS2Address.UnitTest
{
    public class GPS2AddressSpec
    {
        [Fact]
        public void ExtractAddress()
        {
            using (var stream = new FileStream("./test/SampleAddress.json", FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    var addressString = reader.ReadToEnd();
                    var address = JsonConvert.DeserializeObject<GoogleAddressResult>(addressString);
                }
            }
        }
    }
}