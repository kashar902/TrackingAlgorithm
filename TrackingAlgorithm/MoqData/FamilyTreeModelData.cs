using TrackingAlgorithm.Model;

namespace TrackingAlgorithm.MoqData;

public class FamilyTreeModelData
{
    public IEnumerable<FamilyTreeModel> GetDummyData()
    {
        return new List<FamilyTreeModel>
        {
            new FamilyTreeModel { TreeId = 1, FatherId = 0 },
            new FamilyTreeModel { TreeId = 2, FatherId = 1 },
            new FamilyTreeModel { TreeId = 3, FatherId = 1 },
            new FamilyTreeModel { TreeId = 4, FatherId = 2 },
            new FamilyTreeModel { TreeId = 5, FatherId = 2 },
            new FamilyTreeModel { TreeId = 6, FatherId = 3 },
            new FamilyTreeModel { TreeId = 7, FatherId = 3 },
            new FamilyTreeModel { TreeId = 8, FatherId = 4 },
            new FamilyTreeModel { TreeId = 9, FatherId = 4 },
            new FamilyTreeModel { TreeId = 10, FatherId = 5 },
            new FamilyTreeModel { TreeId = 11, FatherId = 5 },
            new FamilyTreeModel { TreeId = 12, FatherId = 6 },
            new FamilyTreeModel { TreeId = 13, FatherId = 6 },
            new FamilyTreeModel { TreeId = 14, FatherId = 7 },
            new FamilyTreeModel { TreeId = 15, FatherId = 7 },
            new FamilyTreeModel { TreeId = 16, FatherId = 8 },
            new FamilyTreeModel { TreeId = 17, FatherId = 8 },
            new FamilyTreeModel { TreeId = 18, FatherId = 9 },
            new FamilyTreeModel { TreeId = 19, FatherId = 9 },
            new FamilyTreeModel { TreeId = 20, FatherId = 10 },
            new FamilyTreeModel { TreeId = 21, FatherId = 10 },
            new FamilyTreeModel { TreeId = 22, FatherId = 11 },
            new FamilyTreeModel { TreeId = 23, FatherId = 11 },
            new FamilyTreeModel { TreeId = 24, FatherId = 12 },
            new FamilyTreeModel { TreeId = 25, FatherId = 12 },
            new FamilyTreeModel { TreeId = 26, FatherId = 13 },
            new FamilyTreeModel { TreeId = 27, FatherId = 13 },
            new FamilyTreeModel { TreeId = 28, FatherId = 14 },
            new FamilyTreeModel { TreeId = 29, FatherId = 14 },
            new FamilyTreeModel { TreeId = 30, FatherId = 15 },
            new FamilyTreeModel { TreeId = 31, FatherId = 15 },
            new FamilyTreeModel { TreeId = 32, FatherId = 16 },
            new FamilyTreeModel { TreeId = 33, FatherId = 16 },
            new FamilyTreeModel { TreeId = 34, FatherId = 17 },
            new FamilyTreeModel { TreeId = 35, FatherId = 17 },
            new FamilyTreeModel { TreeId = 36, FatherId = 18 },
            new FamilyTreeModel { TreeId = 37, FatherId = 18 },
            new FamilyTreeModel { TreeId = 38, FatherId = 19 },
            new FamilyTreeModel { TreeId = 39, FatherId = 19 },
            new FamilyTreeModel { TreeId = 40, FatherId = 20 },
            new FamilyTreeModel { TreeId = 41, FatherId = 20 },
            new FamilyTreeModel { TreeId = 42, FatherId = 21 },
            new FamilyTreeModel { TreeId = 43, FatherId = 21 },
            new FamilyTreeModel { TreeId = 44, FatherId = 22 },
            new FamilyTreeModel { TreeId = 45, FatherId = 22 },
            new FamilyTreeModel { TreeId = 46, FatherId = 23 },
            new FamilyTreeModel { TreeId = 47, FatherId = 23 },
            new FamilyTreeModel { TreeId = 48, FatherId = 24 },
            new FamilyTreeModel { TreeId = 49, FatherId = 24 },
            new FamilyTreeModel { TreeId = 50, FatherId = 25 }
        };

    }
}
