using System;

class Program{
    static void Main(String[] args){
        Job job1 = new Job();
        job1._company = "EggsPlanet";
        job1._jobTitle = "Manager";
        job1._startYear = "2018";
        job1._endYear = "2023";

        Job job2 = new Job();
        job1._company = "Tutoring Services";
        job1._jobTitle = "Minor Tutor";
        job1._startYear = "2022";
        job1._endYear = "2023";
        

        Resume myResume = new Resume();
        myResume._firstName = "Ezra";
        myResume._middleName = "Cyril Kofi";
        myResume._lastName = "Senanu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); 

        
    }
}