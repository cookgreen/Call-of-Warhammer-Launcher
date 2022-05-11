import ('System.IO')

function remove_map_rwn(path, mod)
	mapFullPath  = path .. "\\" .. mod .. "data\\world\\maps\\campaign\\imperial_campaign"
	directoryInfo = DirectoryInfo(mapFullPath)
	for file in directoryInfo.GetFiles() do
		extension = file.Extention;
		if(extension == ".rwn") then
			lfs.rmdir(file)
		end
	end
end