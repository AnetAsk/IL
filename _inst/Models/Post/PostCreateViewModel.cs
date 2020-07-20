using System;
using Domain.Model;

namespace _inst.Models.Post
{
    public class PostCreateViewModel
    {
        public string PhotoPath { get; set; }
        public string Data { get; set; }

        public User User { get; set; }

        public PostCreateViewModel()
        {
            PhotoPath = "https://cdn.pixabay.com/photo/2020/07/15/11/22/raspberry-5407356_960_720.jpg";
        }
    }
}