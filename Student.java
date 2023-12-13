package newpackage.oe;

public class Student implements Comparable
 {
     private String name;
     private int average;





     public Student(String name, int average) {
         this.name = name;
         this.average = average;
     }

     public String getName() {
         return name;
     }

     public int getAverage() {
         return average;
     }

     public void setAverage(int average) {
         this.average = average;
     }



     @Override
     public String toString() {
         return "Student{" +
                 "name='" + name + '\'' +
                 ", average=" + average +
                 '}';
     }

     @Override
     public int compareTo(Object o) {
         return Integer.compare(this.average, ((Student)o).getAverage());
     }

 }
