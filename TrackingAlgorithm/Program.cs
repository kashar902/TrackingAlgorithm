// See https://aka.ms/new-console-template for more information
using TrackingAlgorithm.Algorithms;
using TrackingAlgorithm.MoqData;

Console.WriteLine("Hello, World!");

FamilyTreeModelData database = new FamilyTreeModelData();

#region Front Track 
FamilyTreeFrontTrack familyTreeFrontTrack = new();
familyTreeFrontTrack.GetFamilyTreeWithGenerations(database.GetDummyData().ToList(), 23, 2);
familyTreeFrontTrack.GetFamilyTreeWithOutGenerations(database.GetDummyData().ToList(), 1);
#endregion


#region Back Track
FamilyTreeBackTrack backTrack = new();
//backTrack.BackTrackingFamilyTreeWithGenerations(database.GetDummyData().ToList(), 50, 5);
backTrack.BackTrackingFamilyTree(database.GetDummyData().ToList(), 50);
#endregion
