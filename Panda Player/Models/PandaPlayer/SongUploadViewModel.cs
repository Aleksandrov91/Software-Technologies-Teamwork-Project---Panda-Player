﻿using Panda_Player.Models.Manage.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Panda_Player.Models.PandaPlayer
{
    public class SongUploadViewModel
    {
        public SongUploadViewModel()
        {
           
        }

        //public SongViewModel(string artist, string title, string uploaderId, int categoryId)
        //{
        //    this.Artist = artist;
        //    this.Title = title;
        //    this.UploaderId = uploaderId;
        //    this.CategoryId = categoryId;
        //}

        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Artist *")]
        public string Artist { get; set; }

        [Required]
        [Display(Name = "Title *")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string UploaderId { get; set; }

        //[Display(Name = "Category *")]
        //public int Category { get; set; }

        [Display(Name = "Song Path *")]
        public string SongPath { get; set; }

        [Required]
        public DateTime UploadDate { get; set; }

        public ICollection<Song> Songs { get; set; }

        public int Genre { get; set; }

        //public int GenreId { get; set; }

        public HttpPostedFileBase File { get; set; }
    }
}