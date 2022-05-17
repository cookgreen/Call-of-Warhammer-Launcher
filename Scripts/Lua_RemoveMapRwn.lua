import ('System.IO')

function remove_map_rwn(path, mod)
	mapFullPath  = path .. "\\mods\\" .. mod .. "\\data\\world\\maps\\campaign\\imperial_campaign"
	directoryInfo = DirectoryInfo(mapFullPath)
	local arr = directoryInfo:GetFiles();
	for i=1, arr.Length do
		local fl = arr[i-1]
		extension = fl.Extension;
		if(extension == ".rwn") then
			File.Delete(fl.FullName)
		end
	end
end