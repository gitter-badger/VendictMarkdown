using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u', };
            char[] Glides = { 'w', 'y' };
            char[] Liquids = { 'l', 'r' };
            char[] Nasals = { 'n' };
            char[] Stops = { 't', 'k', 'p' };

            /* Nasal m is not considered cute and must not be used.
               Liquids, Nasal and Fricatives starts the onset.
               A glide may form the median. But Liquids cannot.
               Fricatives and Stops cannot cluster. It must skip directly to the nucleus.
               Coda must end with a Vowel or Nasal.
               Must only have 1 or 2 syllables.
               By standard Vendict Phonotactic Rules, Vowels cannot be clustered.

               // One syllable cuwte.
               


            */
        }
    }
}
