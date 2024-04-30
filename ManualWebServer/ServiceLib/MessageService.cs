namespace ServiceLib
{
    public class MessageService
    {
        public string GetMessage(string name)
        {
            return $"Hello {name}, calling from the ServiceLib.MessageService";
        }
    }
}

