import React from "react";
type Props = {
  title: string;
  subtitule: string;
  center?: boolean;
};
export default function Heading({ title, subtitule, center }: Props) {
  return (
    <div className={center ? "text-center" : "text-start"}>
      <div className="text-2xl font-bold">{title}</div>
      <div className="font-light text-neutral-500 mt-2">{subtitule}</div>
    </div>
  );
}
