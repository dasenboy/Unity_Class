GameObject		= UnityEngine.GameObject;
OneButton = {}
local this = OneButton
function this.OnClick(pr)
	print("11111111111111111111111"..pr.name)
	pr.name = "123"
end