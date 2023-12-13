import newpackage.oe.Student;

import java.util.*;

public class Main {
    public static void main(String[] args) {

        Student student1 = new Student("Alex", 3);
        Student student2 = new Student("Martin", 4);
        Student student3 = new Student("Gloria", 2);
        Student student4 = new Student("Melman", 5);

        ArrayList<Student> students = new ArrayList<>();
        students.add(student1);
        students.add(student2);
        students.add(student3);
        students.add(student4);

        for(Student s: students)
        {
            System.out.println(s.getName() + " " + s.getAverage());
        }
        System.out.println("************************************************");
        PriorityQueue<Student> queue = new PriorityQueue<>(Collections.reverseOrder());
        queue.add(student1);
        queue.add(student2);
        queue.add(student3);
        queue.add(student4);


        //queue.peek().setAverage(3);
        System.out.println(queue.peek().getName() + " " + queue.peek().getAverage());;
        queue.add(queue.poll());

        while(!queue.isEmpty()){
            Student s = queue.poll();
            System.out.println(s.getName() + " " + s.getAverage());
        }



    }



}