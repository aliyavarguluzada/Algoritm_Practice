#include "SearchInsertPosition.h"


static int searchInsert(std::vector<int>& nums, int target) {

	for (int i = 0; i < nums.size(); ++i)
	{
		if (target > nums[nums.size() - 1])
			return nums.size();

		if (target == nums[i] || target < nums[i])
			return i;
		if (target == nums[i] + 1) {
			return i + 1;
		}
	}
	return 0;
}
