using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Caesarcipher
    {
        
        public static void Run()
        {
        	string word = Console.ReadLine();
        	Console.Clear();
        	char [] w =  new char[word.Length];
        	for(int i=0;i<word.Length;i++)
        	{
        		if (word[i]=='a')
        			w[i]='d';
        		else if (word[i]=='b')
        			w[i]='e';
        		else if (word[i]=='c')
        			w[i]='f';
        		else if (word[i]=='d')	
        			w[i]='g';
        		else if (word[i]=='e')	
        			w[i]='h';
        		else if (word[i]=='f')
        			w[i]='i';
        		else if (word[i]=='g')
        			w[i]='j';
        		else if (word[i]=='h')
        		    w[i]='k';
        		else if (word[i]=='i')
        		    w[i]='l';
        		else if (word[i]=='j')
        		    w[i]='m';
        		else if (word[i]=='k')
        		    w[i]='n';
        		else if (word[i]=='l')
        		    w[i]='o';
        		else if (word[i]=='m')
        		    w[i]='p';
        		else if (word[i]=='n')
        		    w[i]='q';
        		else if (word[i]=='o')
        		    w[i]='r';
        		else if (word[i]=='p')
        		    w[i]='s';
        		else if (word[i]=='q')  
        		    w[i]='t';
        		else if (word[i]=='r')  
        		    w[i]='u';
        		else if (word[i]=='s') 
        		    w[i]='v';
        		else if (word[i]=='t') 
        		    w[i]='w';
        		else if (word[i]=='u')  
        		    w[i]='x';
        		else if (word[i]=='v')  
        		    w[i]='y';
        		else if (word[i]=='w') 
        		    w[i]='z';
        		else if (word[i]=='x') 
        		    w[i]='a';
        		else if (word[i]=='y')  
        		    w[i]='b';
        	    else if (word[i]=='z')
        	        w[i]='c';
        	    
        	    else if (word[i]=='A')
        			w[i]='d';
        		else if (word[i]=='B')
        			w[i]='e';
        		else if (word[i]=='C')
        			w[i]='f';
        		else if (word[i]=='D')	
        			w[i]='g';
        		else if (word[i]=='E')	
        			w[i]='h';
        		else if (word[i]=='F')
        			w[i]='i';
        		else if (word[i]=='G')
        			w[i]='j';
        		else if (word[i]=='H')
        		    w[i]='k';
        		else if (word[i]=='I')
        		    w[i]='l';
        		else if (word[i]=='j')
        		    w[i]='m';
        		else if (word[i]=='K')
        		    w[i]='n';
        		else if (word[i]=='L')
        		    w[i]='o';
        		else if (word[i]=='M')
        		    w[i]='p';
        		else if (word[i]=='N')
        		    w[i]='q';
        		else if (word[i]=='O')
        		    w[i]='r';
        		else if (word[i]=='P')
        		    w[i]='s';
        		else if (word[i]=='Q')  
        		    w[i]='t';
        		else if (word[i]=='R')  
        		    w[i]='u';
        		else if (word[i]=='S') 
        		    w[i]='v';
        		else if (word[i]=='T') 
        		    w[i]='w';
        		else if (word[i]=='U')  
        		    w[i]='x';
        		else if (word[i]=='V')  
        		    w[i]='y';
        		else if (word[i]=='W') 
        		    w[i]='z';
        		else if (word[i]=='X') 
        		    w[i]='a';
        		else if (word[i]=='Y')  
        		    w[i]='b';
        	    else if (word[i]=='Z')
        	        w[i]='c'; 
        	     
        	   else if (word[i]=='??')
        			w[i]='??';
        		else if (word[i]=='??')
        			w[i]='??';
        		else if (word[i]=='??')
        			w[i]='??';
        		else if (word[i]=='??')	
        			w[i]='??';
        		else if (word[i]=='??')	
        			w[i]='??';
        		else if (word[i]=='??')
        			w[i]='??';
        		else if (word[i]=='??')
        			w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')
        		    w[i]='??';
        		else if (word[i]=='??')  
        		    w[i]='??';
        		else if (word[i]=='??')  
        		    w[i]='??';
        		else if (word[i]=='??') 
        		    w[i]='??';
        		else if (word[i]=='??') 
        		    w[i]='??';
        		else if (word[i]=='??')  
        		    w[i]='??';
        		else if (word[i]=='??')  
        		    w[i]='??';
        		else if (word[i]=='??') 
        		    w[i]='??';
        		else if (word[i]=='??') 
        		    w[i]='??';
        		else if (word[i]=='??')  
        		    w[i]='??';
        	    else if (word[i]=='??')
        	        w[i]='??'; 
        	    else if (word[i]=='??')  
        		    w[i]='??';
        	    else if (word[i]=='??')
        	        w[i]='??';    

        	    else if (word[i]=='1')
        			w[i]='4';
        		else if (word[i]=='2')
        			w[i]='5';
        		else if (word[i]=='3')
        			w[i]='6';
        		else if (word[i]=='4')	
        			w[i]='7';
        		else if (word[i]=='5')	
        			w[i]='8';
        		else if (word[i]=='6')
        			w[i]='9';
        		else if (word[i]=='7')
        			w[i]='0';
        		else if (word[i]=='8')
        		    w[i]='1';
        		else if (word[i]=='9')
        		    w[i]='2';
        		else if (word[i]=='0')
        		    w[i]='3';    
        	        
        	        
        	        else 
        	        w[i]=word[i];
        	}
        	for(int y=0;y<w.Length;y++)
        	{
        		Console.Write(w[y]);
        	}
        	
        	
        }
    }
}
