using Systems;

namespace Algorithms {
  // Represents custom linked lists.
  class CustomLinkedList {
    Node head;
    
    // Represents nodes.
    public class Node {
      public int data;
      public Node next;
      
      public Node(int d) { data = d; }
    }
    
    // Deletes the K th node from the end of a linked list
    // param: the number of K th node from the end of a linked list
    public void DeleteKthNodeFromEnd(int k) {
      if(head == null || k = 0) {
        return;
      }
      
      // [a, b, c, d] & k = 2
      // first = a; second = a
      Node first = head;
      Node second = head;
      
      // Increases second pointer to the K th node from the head of a linked list
      for(int i = 0; i < k; i++) {
        second = second.next;
        
        if(second.next == null) {
          // k >= the length of linked list
          if(i == k - 1) {
            head = head.next;
          }
          return;
        }
      }
      
      // Increases first and second pointers until second pointer reaches the end of the node,
      // so that first pointer will be at the K th node from the end of the list
      // second = c
      
      while(second.next != null) {
        first = first.next;
        second = second.next;
      }
      
      // first = b; second = d
      // first.next = c;
      
      // Delete the K th node and move the first.next to first.next.next
      first.next = first.next.next;
    }
  }
}
