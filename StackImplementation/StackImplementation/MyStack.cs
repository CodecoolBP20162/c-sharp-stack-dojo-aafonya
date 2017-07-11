using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class MyStack<T>
    {
        public GenericElement<T> LastElement { get; set; }

        public int Size { get; set; }

        public int Counter { get; set; }

        public MyStack(int sizeInput)
        {
            Size = sizeInput;
        }

        public int GetSize()
        {
            return Size;
        }

        public int GetFreeSpacesLeft()
        {
            return Size - Counter;
        }

        public GenericElement<T> Peek()
        {
            return LastElement;
        }

        public void Push(T input)
        {
            if(Counter == Size)
            {
                throw new System.OperationCanceledException("No more free space in the stack");
            }
            GenericElement<T> newGenericElement = new GenericElement<T>(input);
     
            if (LastElement.GetType().Equals(input.GetType())){
                LastElement.upperElement = newGenericElement;   
            }

            LastElement = newGenericElement;
            Counter++;
        }

        public void Push(GenericElement<T> newGenericElement)
        {
            if (LastElement.GetType().Equals(newGenericElement.GetType()))
            {
                LastElement.upperElement = newGenericElement;
            }

            LastElement = newGenericElement;
            Counter++;
        }

        public void Pop()
        {

        }


    }
}

// Declare the generic class.
//public class GenericList<T>
//{
//    void Add(T input) { }
//}
//class TestGenericList
//{
//    private class ExampleClass { }
//    static void Main()
//    {
//        // Declare a list of type int.
//        GenericList<int> list1 = new GenericList<int>();

//        // Declare a list of type string.
//        GenericList<string> list2 = new GenericList<string>();

//        // Declare a list of type ExampleClass.
//        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
//    }
//}