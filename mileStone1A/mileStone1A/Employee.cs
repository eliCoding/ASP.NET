using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mileStone1A
{
    class Employee
    {
      private string _name;
      private int _idNumber;
      private string _department;
      private string _position;

      public Employee() { 

        _name = "";
        _idNumber = 0;
        _department = "";
        _position = "";
      }

      public Employee(string name_, int idNumber_, string department_, string position_) {
          _name = name_;
          _idNumber = idNumber_;
          _department = department_;
          _position = position_;
      
      }
      public Employee(string name_, int idNumber_, string department_, string position_)
      {
          _name = name_;
          _idNumber=idNumber_ ;
          department_ = "";
          position_ = "";
      }
      public string Name
      {
          get
          {
              return _name;
          }
          
          
          set; }
      public int IdNumber {
          get
          {

              return _idNumber;
          }
      
      }
      public string Department {

          get
          {
              return _department;
          }
          
          set; }
      public string Position {
          get
          {
              return _position;

          }
          
          set; }


      //public override string ToString()
      //{
      //   // return base.ToString() + ": " + value.ToString();
      //}
    }

   




}
