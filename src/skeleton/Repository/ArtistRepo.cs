﻿using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using skeleton.Data;
using skeleton.Models;

namespace skeleton.Repository {
    public class ArtistRepo : IArtistRepo {

        private List<Artist> artists = new List<Artist>();

        public ArtistRepo( [FromServices]AssetMapper assetMapper ) { //Dependecy Injected here, (this could be a database service or any other repository of assets for the webpage)
            this.artists = assetMapper.artists;
        }
        public Artist IArtistRepo.GetByName( string name ) {
            return artists.Find( artist => artist.Name == name );
        }
        public Artist IArtistRepo.GetById( int id ) {
            return artists.Find( artist => artist.Id == id );
        }
        public IList<Artist> GetAll() {
            return artists;
        }
    }
}
