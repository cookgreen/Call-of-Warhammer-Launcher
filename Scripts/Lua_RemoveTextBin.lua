import ('System.IO')

function remove_text_bin(path, mod)
	textFullPath  = path .. "\\" .. mod .. "data\\text"
	directoryInfo = DirectoryInfo(mapFullPath)
	for fl in directoryInfo.GetFiles() do
		extension = fl.Extension;
		if(extension == ".bin") then
			lfs.rmdir(fl)
		end
	end
end