#include <cstdint>
#include <string>
#include <unordered_map>
#include <unordered_set>

using Ingredients = std::unordered_map<std::string, int>;

int cakes(const Ingredients &recipe, const Ingredients &available)
{
    std::unordered_set<std::string> recipeIngr;
    int res = INT32_MAX;
    for (const auto &pair: available)
    {
        const auto it = recipe.find(pair.first);
        if (it != recipe.end())
        {
            const int min = it->second;
            int maxForCurrIngredient = pair.second / min;
            if (res > maxForCurrIngredient)
            {
                res = maxForCurrIngredient;
            }

            recipeIngr.emplace(pair.first);
        }
    }

    if (recipeIngr.size() < recipe.size())
    {
        return 0;
    }

    return res;
}
