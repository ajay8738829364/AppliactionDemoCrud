using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApplicationDemo.Models
{
    public class DemoService:IDemo
    {
        public DemoContext Context { get; }
        public DemoService(DemoContext context)
        {
            Context = context;
        }
        public Demo AddDemo(Demo demo)
        {
            Context.Demos.Add(demo);
            Context.SaveChanges();

            return demo; 
        }

        public List<Demo> GetDemo()
        {
            return Context.Demos.ToList();
        }
        public bool Delete(int id)
        {
            if (Context.Demos.Any(e => e.Id == id))
            {
                var emp = Context.Demos.SingleOrDefault(e => e.Id == id);
                Context.Demos.Remove(emp);
                Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Demo EditById(int Id)
        {
            var emp = Context.Demos.SingleOrDefault(e => e.Id == Id);
            return emp;

        }
       public Demo UpdateDemo(Demo demo)
        {
            
            var emp = Context.Demos.SingleOrDefault(e => e.Id == demo.Id);
            emp.Name = demo.Name;
            emp.Email = demo.Email;
            emp.Salary = demo.Salary; 
            emp.Dept = demo.Dept;
            Context.Demos.Update(emp);
            Context.SaveChanges();
            return emp;
                
    
        }
    }
}
