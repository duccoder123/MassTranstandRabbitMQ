import React from "react";
import Countdown from "react-countdown";
import { Props, renderer } from "./CountDownTimer";

export default function CountDownTimer({ auctionEnd }: Props) {
  return (
    <div>
      <Countdown date={auctionEnd} renderer={renderer} />
    </div>
  );
}
