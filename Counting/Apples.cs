using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    public class Apples : ICountable, IApples
    {
        public Colour colour;
    }

    public interface IApples
    {
      
    }

    public enum Colour
    {
        Red,
        Green,
        Yellow,
    }
}
