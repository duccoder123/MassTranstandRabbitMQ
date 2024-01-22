export type PagedResult<T> = {
  results: T[];
  pageCount: number;
  pageTotal: number;
};

export type Auction = {
  id: string;
  reservePrice: number;
  seller: string;
  winner?: string;
  soldAmouy: number;
  currentHighBid: number;
  createdAt: string;
  updatedAt: string;
  auctionEnd: string;
  status: string;
  make: string;
  model: string;
  year: number;
  color: string;
  mileage: number;
  imageUrl: string;
};
