# C-sharp-Mvvm-Wpf-TabControl
C# Wpf Mvvm  Tab control
I already made small application in C# using Windows Forms. After that I want to make same application but using WPF and MvvM architecture.
At the very beginning, I encountered the problem of how to open a person in Tab control by clicking on the list view. After a few weeks of searching for solutions, of which there were many, but none of them fully suited my needs, and if they did, they required the use of libraries that I didn't really like to be in my application from the very beginning.

**First of all, I want to say thank you to Kevin Bost.**
After watching his YouTube channel  
C#/WPF - Deep dive into the TabControl
https://www.youtube.com/watch?v=l2W8v4udBbU and 
C#/WPF - Learn MVVM with the .NET Community Toolkit
https://www.youtube.com/watch?v=uVIzK2snugk

I learned a lot from him about Community Toolkit and I used his code to make Tab control example and many others with their solutions. 
**If anybody recognize his code let me know I will update this with your name. Thanks a lot!**

You can download the code and send me your suggestions for improvement. As you can see 

**As you can see in the picture, the application allows clicking on a person twice to open a new tab for the same person. If anyone has a solution to solve this, I would appreciate your help. A good solution would be if the person is already open, not to open a new tab control again, but to switch the focus to that person and show the data.**


![Tabcontrol1](https://user-images.githubusercontent.com/37701426/222963571-fd2f936b-b628-4d4b-93f5-a350d4d7c957.png)

I used a PostgreSQL database. Here is the script to create the necessary table

CREATE TABLE IF NOT EXISTS public.students
(
    id integer NOT NULL DEFAULT nextval('students_id_seq'::regclass),
    firstname character varying(50) COLLATE pg_catalog."default",
    lastname character varying(50) COLLATE pg_catalog."default",
    dob date,
    CONSTRAINT students_pkey PRIMARY KEY (id)
)
