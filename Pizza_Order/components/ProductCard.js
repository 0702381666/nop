import React from 'react';
import { View, Text, Image, TouchableOpacity } from 'react-native';

const ProductCard = ({ product, onPress }) => {
  return (
    <TouchableOpacity onPress={onPress}>
      <View>
        <Image source={{ uri: product.image }} style={{ width: 100, height: 100 }} />
        <Text>{product.name}</Text>
        <Text>${product.price.toFixed(2)}</Text>
        <Text>Add</Text>
      </View>
    </TouchableOpacity>
  );
};

export default ProductCard;
