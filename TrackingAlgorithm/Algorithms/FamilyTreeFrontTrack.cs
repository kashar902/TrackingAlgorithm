using TrackingAlgorithm.Model;

namespace TrackingAlgorithm.Algorithms;

public class FamilyTreeFrontTrack
{
    public IEnumerable<FamilyTreeModel> GetFamilyTreeWithGenerations
        (List<FamilyTreeModel> database, int rootId, int noOfGeneration)
    {
        List<FamilyTreeModel> result = new();
        Stack<(int, int)> stack = new(); // Use a tuple to store both the current person ID and generation level
        HashSet<int> visited = new();

        // Push the root node onto the stack with generation level 1
        stack.Push((rootId, 1));

        while (stack.Count > 0)
        {
            (int currentId, int generation) = stack.Pop();

            if (!visited.Contains(currentId) && generation <= noOfGeneration) // Limit to 3 generations
            {
                // Find the person in the database by TreeId
                FamilyTreeModel? person = database.FirstOrDefault(p => p.TreeId == currentId);
                if (person != null)
                {
                    result.Add(person);
                    _ = visited.Add(currentId);

                    // Find all children of the current person
                    List<int> childrenIds = database
                        .Where(p => p.FatherId == currentId)
                        .Select(p => p.TreeId)
                        .ToList();

                    // Push children onto the stack for further exploration with the next generation level
                    foreach (int childId in childrenIds)
                    {
                        stack.Push((childId, generation + 1));
                    }
                }
            }
        }
        return result;
    }
}
