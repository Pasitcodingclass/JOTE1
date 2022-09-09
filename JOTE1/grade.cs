using System;
public class Grade{
    public static void GradePlease(){
        double GradeNaja;
        Console.Write("sai Grade Isus : ");
        GradeNaja = double.Parse(Console.ReadLine());
        CumnuandGrade(ref GradeNaja);

    }
    public static void CumnuandGrade(ref double GradePlease){
        string AunneeGrade;
        if(GradePlease <= 50 ){
            AunneeGrade = "F";
            }
            else if( (GradePlease <= 54)&&(GradePlease>50)) 
            AunneeGrade = "D";
             else if( (GradePlease <= 69)&&(GradePlease>=55)) 
            AunneeGrade = "C";
             else if( (GradePlease <= 74)&&(GradePlease>=70)) 
            AunneeGrade = "B";
             else if( (GradePlease <= 79)&&(GradePlease>=75)) 
            AunneeGrade = "B+";
            else if( (GradePlease <= 100)&&(GradePlease>=80)) 
            AunneeGrade = "A";
            else
            AunneeGrade ="error";

            Console.Write(AunneeGrade);


        }


       

    }
