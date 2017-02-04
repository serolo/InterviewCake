/*
Exercise 11

I'm making a search engine called MillionGazillion™.
I wrote a crawler that visits web pages, stores a few keywords in a database, and follows links to other web pages. I noticed that my crawler was wasting a lot of time visiting the same pages over and over, so I made a hash set, visited, where I'm storing URLs I've already visited. Now the crawler only visits a URL if it hasn't already been visited.

Thing is, the crawler is running on my old desktop computer in my parents' basement (where I totally don't live anymore), and it keeps running out of memory because visited is getting so huge.

How can I trim down the amount of space taken up by visited?

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
        
        /*
            Time Complexity: O(2^n)
            Space Complexity: O(n)
        */
        public static bool IsABinarySearchTree1( TreeNode root ) {
            if( root == null ) {
                return true;
            }

            if( root.left != null && root.left.data > root.data  ) {
                return false;
            }
            else if( root.right != null && root.right.data < root.data) {
                return false;
            }
            else {
                return IsABinarySearchTree1( root.left ) && IsABinarySearchTree1( root.right );
            }
        }
    }

public class TrieNode {

    private Dictionary<char, TrieNode> _nodeChildren = new Dictionary<char, TrieNode>();

    public bool HasChildNode(char character) {
        return _nodeChildren.ContainsKey(character);
    }

    public void MakeChildNode(char character) {
        _nodeChildren[character] = new TrieNode();
    }

    public TrieNode GetChildNode(char character) {
        return _nodeChildren[character];
    }

}

public class Trie {

    private const char EndOfWordMarker = '\0';

    private TrieNode _rootNode = new TrieNode();

    public bool CheckPresentAndAdd(string word) {
        var currentNode = _rootNode;
        bool isNewWord = false;

        // Work downwards through the trie, adding nodes
        // as needed, and keeping track of whether we add
        // any nodes.
        foreach (var character in word) {
            if( !currentNode.HasChildNode(character) ) {
                isNewWord = true;
                currentNode.MakeChildNode(character);
            }

            currentNode = currentNode.GetChildNode(character);
        }

        // Explicitly mark the end of a word.
        // Otherwise, we might say a word is
        // present if it is a prefix of a different,
        // longer word that was added earlier.
        if( !currentNode.HasChildNode(EndOfWordMarker) )
        {
            isNewWord = true;
            currentNode.MakeChildNode(EndOfWordMarker);
        }

        return isNewWord;
        
    }
}
}