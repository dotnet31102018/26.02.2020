var translations = new Dictionary<string, string>
                   {
                       {"cat", "chat"},
                       {"dog", "chien"},
                       {"fish", "poisson"},
                       {"bird", "oiseau"}
                   };

// Find translations for English words containing the letter "a",
// sorted by length and displayed in uppercase
IEnumerable<string> query = translations
	.Where   (t => t.Key.Contains("a"))
	.OrderBy (t => t.Value.Length)
	.Select  (t => t.Value.ToUpper());

// The same query constructed progressively:
var filtered   = translations.Where (t => t.Key.Contains("a"));
var sorted     = filtered.OrderBy   (t => t.Value.Length);
var finalQuery = sorted.Select      (t => t.Value.ToUpper());
