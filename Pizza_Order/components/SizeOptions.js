import React from 'react';
import { View, Text, Pressable } from 'react-native';

const SizeOptions = ({ sizes, selectedSize, onSelect }) => {
  return (
    <View>
      {sizes.map((size) => (
        <Pressable
          key={size.label}
          onPress={() => onSelect(size)}
          style={{
            flexDirection: 'row',
            alignItems: 'center',
            marginVertical: 5,
          }}
        >
          <View style={{
            height: 20,
            width: 20,
            borderWidth: 1,
            borderColor: '#000',
            borderRadius: 10,
            marginRight: 8,
            justifyContent: 'center',
            alignItems: 'center',
          }}>
            {selectedSize.label === size.label && (
              <View style={{
                height: 10,
                width: 10,
                borderRadius: 5,
                backgroundColor: '#000'
              }} />
            )}
          </View>
          <Text>{size.label} - ${size.price.toFixed(2)}</Text>
        </Pressable>
      ))}
    </View>
  );
};

export default SizeOptions;