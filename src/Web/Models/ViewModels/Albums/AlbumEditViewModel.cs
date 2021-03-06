﻿using Inkett.ApplicationCore.Entitites;
using Inkett.Web.Common.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Inkett.Web.Models.ViewModels.Albums
{
    public class AlbumEditViewModel : IMapFrom<Album>
    {
        public int Id { get; set; }

        [Display(Name = "Album Title")]
        public string Title { get; set; }

        public string PictureUri { get; set; }

        public string Description { get; set; }
    }
}
