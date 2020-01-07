using Microsoft.AspNetCore.Mvc;

namespace Package.Models
{
  public class Parcel
  {
    public int _Length { get; set; }
    public int _Width { get; set; }
    public int _Height { get; set; }
    public int _Volume { get; set; }


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
    //Here we have the constructors that will be passed into our route then to our main page
  }
}