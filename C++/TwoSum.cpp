#include "TwoSum.h"

std::vector<int> TwoSum::twoSum(std::vector<int>& nums, int target)
{
	std::map<int, int> values;

	for (int i{ 0 }; i < nums.size(); ++i)
	{
		int secondNum = target - nums[i];
		if (values.count(secondNum))
			return { values[secondNum],i };
		values[nums[i]] = i;
	}
	return{};
}
