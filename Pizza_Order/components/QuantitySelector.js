import React from 'react';
import { View, Text, Pressable } from 'react-native';

const QuantitySelector = ({ quantity, onIncrease, onDecrease }) => {
  return (
    <View style={{ flexDirection: 'row', alignItems: 'center', marginVertical: 10 }}>
      <Pressable
        onPress={onDecrease}
        style={{
          paddingHorizontal: 10,
          paddingVertical: 5,
          borderWidth: 1,
          borderColor: '#000',
          marginRight: 10,
        }}
      >
        <Text>-</Text>
      </Pressable>
      <Text>{quantity}</Text>
      <Pressable
        onPress={onIncrease}
        style={{
          paddingHorizontal: 10,
          paddingVertical: 5,
          borderWidth: 1,
          borderColor: '#000',
          marginLeft: 10,
        }}
      >
        <Text>+</Text>
      </Pressable>
    </View>
  );
};

export default QuantitySelector;