using System;

namespace Card
{
    public class SpecialCard
    {
        private string name;
        private string type;
        private string buffType;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Bufftype { get => buffType; set => buffType = value; }

        public SpecialCard(string name, string type, string buffType)
        {
            this.name = name;
            this.type = type;
            this.buffType = buffType;

        }
    }
}
