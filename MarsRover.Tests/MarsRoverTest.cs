using System;
using MarsRover.Application.Library;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace MarsRover.Tests
{
   
    /// test sınıfı
   
    public class MarsRoverTest
    {
        
        /// birinci çıkış için test yöntemi
      
        public void Firstrover()
        {
            Plato.RoverAdd(1, 2, 'N');

            Plato.hareket(0, 'l');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'l');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'l');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'l');
            Plato.hareket(0, 'm');
            string durum = Plato.hareket(0, 'm');

             Assert.Equal("1,3,N", durum);
        }


        /// ikinci çıkış için test yöntemi

        public void Secondrover()
        {
            Plato.RoverAdd(3, 3, 'E');

            Plato.hareket(0, 'm');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'r');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'r');
            Plato.hareket(0, 'm');
            Plato.hareket(0, 'r');
            Plato.hareket(0, 'r');

            string durum = Plato.hareket(0, 'm');

            Assert.Equal("5,1,E", durum);
        }


    }
}
