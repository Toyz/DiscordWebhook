﻿namespace TraceLd.DiscordWebhook.Models
{
    public class Field
    {
        public Field()
        {
        }

        public Field(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        public string Name { get; set; }
        public string Value { get; set; }
    }
}