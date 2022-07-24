/*
In this kata you have to create all permutations of a non empty input string and remove duplicates, if present. This means, you have to shuffle all letters from the input in all possible orders.

Examples:

* With input 'a'
* Your function should return: ['a']
* With input 'ab'
* Your function should return ['ab', 'ba']
* With input 'aabb'
* Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
The order of the permutations doesn't matter.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        var permutations = new HashSet<string> { s };

        for (int i = 0; i < s.Length; i++)
        {
            permutations.UnionWith(SinglePermutations(s.Remove(i, 1)).Select(p => s[i] + p));
        }
        return permutations.ToList();

    }
}
