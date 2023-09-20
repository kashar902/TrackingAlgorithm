// See https://aka.ms/new-console-template for more information
using TrackingAlgorithm.Algorithms;
using TrackingAlgorithm.Model;

Console.WriteLine("Hello, World!");


FamilyTreeFrontTrack familyTreeFrontTrack = new();
// List Coming From Database , rootNode , No. Of Generations to Open
familyTreeFrontTrack.GetFamilyTreeWithGenerations(new List<FamilyTreeModel>(), 23, 2);
