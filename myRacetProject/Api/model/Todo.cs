﻿namespace api_models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string description { get; set; }

        public int Duration { get; set; }

        public int status { get; set; }

    }
}
