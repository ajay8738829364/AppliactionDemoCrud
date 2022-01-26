using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
   public interface IDemo
    {
        
        Demo AddDemo(Demo demo);
        List<Demo> GetDemo();
        bool Delete(int id);
        Demo EditById(int id);
        Demo UpdateDemo(Demo demo);
    }
}
