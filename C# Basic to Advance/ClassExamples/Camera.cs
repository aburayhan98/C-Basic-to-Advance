using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Camera :Product  //inheritance  camera itself a product product is a parent class and camera is his child class
    {
        public int model;
        public string color;

        public Camera()
        {
            id = 1;
        }
        public void TakePicture()  // Camera can take picture
        {
            id = 2;
        }

        public sealed override string GetUrlFriendlyName() //sealed is use for when we don't want to access another class except the same class
        {
            return name.Remove(' ', '+');
        }
    }
}
/*
 * Encapsulation is like an capsule,it can help to keep seperate
 * Inheritance is a kind of subtype
 * it can added in additional thing
 * relatively inheritate
 * accessibility
 * private-same classes
 * public-all classes
 * protected-child classe + same class,it will be use when we use inheritance
 * internal-same class project
 * readonly can be set in constructor, 
 * 
 */