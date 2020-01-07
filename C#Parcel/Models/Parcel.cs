using Microsoft.AspNetCore.Mvc;

namespace Package.Models
{
  public class Parcel
  {
    public int _Length { get; set; }
    public int _Width { get; set; }
    public int _Height { get; set; }
    public int _Volume { get; set; }
    public int _Price { get; set; }


    public Parcel(int length , int width, int height)
    {
        _Length = length;
        _Width = width;
        _Height = height;
    }

    public void Volume()
    {
      this._Volume = this._Length * this._Width * this._Height;
    }

    public void Price()
    {
      if(this._Volume < 2500 && this._Volume > 30) {
        this._Price = this._Volume;
      } else {
        this._Price = 5;
      }
    }
  }
}