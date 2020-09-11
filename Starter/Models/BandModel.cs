using System.Collections.Generic;
// add required model annotations
namespace Starter.Models
{
    public class BandModel
    {
        public int id{get;set;}
        public string bandName{get;set;}
        public int yearFormed{get;set;}
        public int numberOfMembers{get;set;}
        public bool isActive{get;set;}
        public List<AlbumModel> albums{get;set;}
    }
}