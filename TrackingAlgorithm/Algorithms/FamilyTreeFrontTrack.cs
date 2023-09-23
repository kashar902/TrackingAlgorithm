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

    /*  
     *  Approach todo with the generation using SQL SP to make it faster 
     *  
     *  
     *  CREATE PROCEDURE GetFamilyTreeWithGenerations
     *       @rootId INT,
     *       @noOfGeneration INT
     *   AS
     *   BEGIN
     *       WITH FamilyTreeCTE AS
     *       (
     *           SELECT
     *               TreeId,
     *               FatherId.
     *               1 AS Generation
     *           FROM
     *               FamilyTree
     *           WHERE
     *               TreeId = @rootId
     *   
     *           UNION ALL
     *   
     *           SELECT
     *               ft.TreeId,
     *               ft.FatherId
     *               c.Generation + 1 AS Generation
     *           FROM
     *               FamilyTree AS ft
     *           JOIN
     *               FamilyTreeCTE AS c
     *           ON
     *               ft.FatherId = c.TreeId
     *           WHERE
     *               c.Generation < @noOfGeneration
     *       )
     *
     *       SELECT
     *           TreeId,
     *           FatherId,
     *           Generation
     *       FROM
     *           FamilyTreeCTE;
     *   END
     *
     */

    public IEnumerable<FamilyTreeModel> GetFamilyTreeWithOutGenerations
        (List<FamilyTreeModel> database, int rootId)
    {
        List<FamilyTreeModel> result = new();
        Stack<int> stack = new(); // Use a tuple to store both the current person ID and generation level
        HashSet<int> visited = new();

        // Push the root node onto the stack with generation level 1
        stack.Push(rootId);

        while (stack.Count > 0)
        {
            int currentId = stack.Pop();

            if (!visited.Contains(currentId))
            {
                FamilyTreeModel? person = database.FirstOrDefault(p => p.TreeId == currentId);
                if (person != null)
                {
                    result.Add(person);
                    _ = visited.Add(currentId);

                    List<int> childrenIds = database
                        .Where(p => p.FatherId == currentId)
                        .Select(p => p.TreeId)
                        .ToList();

                    foreach (int childId in childrenIds)
                    {
                        stack.Push(childId);
                    }
                }
            }
        }

        return result;
    }
}
