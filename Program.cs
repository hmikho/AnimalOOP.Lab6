using System;
using Microsoft.VisualBasic;

namespace Lab6_OOPArv
{
   public class Program
   {
      public static void Main(string[] args)
      {
         Lion simba = new Lion("Simba", "Confident", "Carnivore", "Savannah", "Orange/Brown");
         Owl hedwig = new Owl("Hedwig", "Nocturnal", "Carnivore", "Forest", "White");
         Dog sven = new Dog("Sven", "Playful", "Carnivore", "Human homes", "Advanced");

         AfricanLion mufasa = new AfricanLion("Mufasa", "Territorial", "Carnivore", "African Savannah", "Dark Golden");
         AsianLion remus = new AsianLion("Remus", "Solitary", "Carnivore", "Indian Jungle", "Light Brown");
         
         simba.DisplayInfo();
         simba.MakeSound();
         
         hedwig.DisplayInfo();
         hedwig.MakeSound();
         
         sven.DisplayInfo();
         sven.MakeSound();
         
         mufasa.MakeSound();
         
         remus.MakeSound();
        
      }

   }

}