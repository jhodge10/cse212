namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: pay rent, check email, sleep, homework
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("homework",1);
        priorityQueue.Enqueue("sleep",2);
        priorityQueue.Enqueue("check email",3);
        priorityQueue.Enqueue("pay rent",4);
        
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: I had the orders incorrect and had to redo the order I had them in

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: pay rent, check email, homeowrk, sleep
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("homework",1);
        priorityQueue.Enqueue("sleep",1);
        priorityQueue.Enqueue("check email",2);
        priorityQueue.Enqueue("pay rent",2);
        
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: No defects for this one as it was almost copy and paste

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}