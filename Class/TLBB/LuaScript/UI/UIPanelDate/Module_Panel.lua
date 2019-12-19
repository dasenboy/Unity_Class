local tab = {}
tab["Panel"] = function (self,isDelete)
 	local moudlecnt = self:GetUIModule()
	self.Spr_1 = (not isDelete) and moudlecnt.List_Sprite:get_Item(0) or nil 
	self.Spr_2 = (not isDelete) and moudlecnt.List_Sprite:get_Item(1) or nil 
	end
return tab