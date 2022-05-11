import ('System.IO')

function remove_map_rwn(path, mod)
	mapFullPath  = path .. "\\" .. mod .. "data\\world\\maps\\campaign\\imperial_campaign"
	directoryInfo = DirectoryInfo(mapFullPath)
	for fl in directoryInfo.GetFiles() do
		extension = fl.Extention;
		if(extension == ".rwn") then
			File.Delete(fl.FullName)
		end
	end
end