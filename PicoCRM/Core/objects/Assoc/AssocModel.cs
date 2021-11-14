

namespace PicoCRM.Modules.Dto.Request.Assoc
{
    public class From
    {
        public string id { get; set; }
    }

    public class To
    {
        public string id { get; set; }
    }

    public class Input
    {
        public From from { get; set; }
        public To to { get; set; }
        public string type { get; set; }
    }

    public class Assoc
    {
        public List<Input> inputs { get; set; }
    }
}
