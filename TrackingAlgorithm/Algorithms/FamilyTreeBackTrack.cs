using TrackingAlgorithm.Model;

namespace TrackingAlgorithm.Algorithms;

public class FamilyTreeBackTrack
{
    public IEnumerable<FamilyTreeModel> BackTrackingFamilyTree(List<FamilyTreeModel> database, int rootId)
    {
        HashSet<FamilyTreeModel> result = new();
        HashSet<int> visitedNode = new();
        Stack<int> stack = new();

        stack.Push(rootId);

        while (stack.Count > 0)
        {
            var currentId = stack.Pop();
            if (!visitedNode.Contains(currentId))
            {
                FamilyTreeModel? person =
                    database.FirstOrDefault(x => x.TreeId == currentId);
                if (person is not null)
                {
                    List<FamilyTreeModel> persons =
                     database.Where(x => x.FatherId == person.FatherId).ToList();

                    _ = visitedNode.Add(currentId);
                    foreach (var item in persons)
                    {
                        _ = result.Add(item);
                    }

                    stack.Push(person.FatherId);
                }
            }
        }

        return result;
    }


    public IEnumerable<FamilyTreeModel> BackTrackingFamilyTreeWithGenerations(List<FamilyTreeModel> database, int rootId, int requestedGeneration)
    {
        List<FamilyTreeModel> result = new();
        HashSet<int> visitedNode = new();
        Stack<(int, int)> stack = new();

        stack.Push((rootId, 1));

        while (stack.Count > 0)
        {
            (int currentId, int currentGeneration) = stack.Pop();
            if (!visitedNode.Contains(currentId) && requestedGeneration >= currentGeneration)
            {
                FamilyTreeModel? person =
                    database.FirstOrDefault(x => x.TreeId == currentId);
                if (person is not null)
                {
                    List<FamilyTreeModel> persons =
                     database.Where(x => x.FatherId == person.FatherId).ToList();

                    _ = visitedNode.Add(currentId);
                    result.AddRange(persons);

                    stack.Push((person.FatherId, currentGeneration + 1));
                }
            }
        }
        return result;
    }
}
