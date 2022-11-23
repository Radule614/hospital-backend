﻿using HospitalLibrary.Core.Model;
using HospitalLibrary.Core.Repository;
using HospitalLibrary.HospitalMap.Model;
using System.Collections.Generic;

namespace HospitalLibrary.Core.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public IEnumerable<Room> GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public Room GetByNumber(string number)
        {
            return _roomRepository.GetByNumber(number);
        }

        public IEnumerable<Room> GetRooms(string buildingId, int floorId)
        {
            return _roomRepository.GetRooms(buildingId, floorId);
        }

        public void Create(Room room)
        {
            _roomRepository.Create(room);
        }

        public void Update(Room room)
        {
            _roomRepository.Update(room);
        }
        

        public void Delete(Room room)
        {
            _roomRepository.Delete(room);
        }

        public IEnumerable<Equipment> GetEquipment(int id)
        {
            return _roomRepository.GetEquipment(id);
        }

		public IEnumerable<Equipment> GetAllEquipment()
		{
			return _roomRepository.GetAllEquipment();
		}

		public IEnumerable<Room> SearchForEquipment(string query)
        {
            return _roomRepository.SearchForEquipment(query);
        }
        public void MoveEquipment(MoveRequest moveRequest)
        {
            _roomRepository.MoveEquipment(moveRequest);
        
        
        }
    }
}
