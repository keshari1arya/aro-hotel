import { createAction, props } from '@ngrx/store';
import { IHotel } from '../infrastructure/models/hotel';

export const getHotels = createAction('[App] get hotels');
export const setHotels = createAction(
  '[App] set hotels',
  props<{ hotels: IHotel[] }>()
);

export const getHotelDetails = createAction(
  '[App] get hotel details',
  props<{ id: number }>()
);
export const setHotelDetails = createAction(
  '[App] set hotel details',
  props<{ hotel: IHotel }>()
);

export const CreateHotel = createAction(
  '[App] create hotel',
  props<{ hotel: IHotel }>()
);

export const uploadImages = createAction(
  '[App] upload images',
  props<{ file: File[], hotelId: string, roomId: string }>()
);

export const uploadSuccess = createAction('[App] upload success');
