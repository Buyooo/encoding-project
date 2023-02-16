namespace encoding_project.Service
{
    public class EncodingService
    {
        public static string EncodeString(string value)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(value);
            return System.Convert.ToBase64String(plainTextBytes);
        }        
    }
}
