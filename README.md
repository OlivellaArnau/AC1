Prompts IA:
Vaig utilitzar coopilot per arreglar les comrpovacions finals les linies que em va donar van ser arreglades amb ChatGPT quedan finalment així
public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            var ranking = scores
                .GroupBy(score => new { score.Player, score.Mission })
                .Select(group => group.OrderByDescending(score => score.Scoring).First())
                .ToList();
            return ranking;
        }
Tambe vaig utilitzar ChatGPT per preguntar on s'havien de colocar les diferents funcions de comprovació:

